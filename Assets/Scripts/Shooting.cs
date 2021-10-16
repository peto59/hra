using UnityEngine;
using System.Collections;
using System.Collections.Generic; //Needed for Lists
using System.Xml; //Needed for XML functionality
using System.Xml.Serialization; //Needed for XML Functionality
using System.IO;
using System.Xml.Linq; //Needed for XDocument
using System.Globalization;

public class Shooting : MonoBehaviour
{

    [SerializeField] Transform cam;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 10f;
    bool hold = false;
    string mode = "Semi";
    bool last = false;
    [SerializeField] float lastShot = 0;

    [SerializeField] AudioClip gunshot;
    [SerializeField] AudioClip click;
    [SerializeField] AudioClip shellSound;
    [SerializeField] Transform Shell;
    [SerializeField] AudioSource prefab;


    List<string> modes;

    float fireRate;
    int maxAmmo;
    int ammo;
    int shotsToFire;
    int burstSize;
    float recoil;
    bool clicked = false;

    public void Start()
    {
        modes = new List<string>();
        GetWeapon("Famas");
    }

    public void Update()
    {
        lastShot += Time.deltaTime;

        switch (mode)
        {
            case "Semi":
                if (hold && !last && lastShot >= fireRate)
                {
                    Shoot();
                }

                break;

            case "Auto":
                if (hold && lastShot >= fireRate)
                {
                    Shoot();
                }

                break;

            case "Burst":
                if (((hold && !last && shotsToFire == 0) || shotsToFire > 0) && lastShot >= fireRate)
                {
                    if (shotsToFire == 0)
                    {
                        shotsToFire = burstSize;
                    }
                    shotsToFire -= 1;
                    Shoot();
                }

                break;
        }

        last = hold;
    }

    private void Shoot()
    {
        var audioSource = Instantiate(prefab, transform);
        if (ammo > 0)
        {
            audioSource.clip = gunshot;
            print("Shot");

            ammo -= 1;
            lastShot = 0;

            RaycastHit hit;
            if (Physics.Raycast(cam.position, cam.forward, out hit, range))
            {
                var target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.Hit(damage);
                }
                print(hit.transform.name);
            }
            var shellSource = Instantiate(prefab, Shell);
            shellSource.clip = shellSound;
            shellSource.Play();
        }
        else if (!clicked)
        {
            clicked = true;
            audioSource.clip = click;
        }
        audioSource.Play();
    }

    public void Hold()
    {
        hold = true;
    }
    public void Release()
    {
        clicked = false;
        hold = false;
    }

    public void Reload()
    {
        ammo = maxAmmo;
    }

    public void ChangeMode()
    {
        int next = modes.IndexOf(mode) + 1;
        if (next > modes.Count-1)
        {
            next = 0;
        }
        mode = modes[next];
    }

    private void GetWeapon(string name)
    {

        XDocument doc = XDocument.Load("Assets/GunTypes/"+name+".xml");
        //print(doc.Descendants("fireRate").Value);
        foreach (XElement el in doc.Descendants("fireRate"))
        {
            fireRate = float.Parse(el.Value, NumberStyles.Any, CultureInfo.InvariantCulture);
        }
        foreach (XElement el in doc.Descendants("ammo"))
        {
            maxAmmo = int.Parse(el.Value);
            ammo = maxAmmo;
        }
        foreach (XElement el in doc.Descendants("recoil"))
        {
            recoil = float.Parse(el.Value, NumberStyles.Any, CultureInfo.InvariantCulture);
        }
        foreach (XElement el in doc.Descendants("modes").Descendants())
        {
            modes.Add(el.Name.ToString());
        }
        mode = modes[0];
        if (modes.Contains("Burst"))
        {
            foreach (XElement el in doc.Descendants("BurstSize"))
            {
                burstSize = int.Parse(el.Value);
            }
        }
        
        

    }
}
