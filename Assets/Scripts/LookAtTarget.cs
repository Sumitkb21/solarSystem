using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;
using UnityEngine.Rendering.Universal.Internal;


public class LookAtTarget : MonoBehaviour {

	static public GameObject target; // the target that the camera should look at
	public GameObject Text ;
	void Start () {
      

        if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
			if (target.tag == "Sun")
			{
                Text.GetComponent<TextMeshProUGUI>().text = "The Sun, a luminous sphere of hot plasma, is the central star of our solar system. With a radius of approximately 696,340 kilometers, it dominates the solar system and holds more than 99.8% of its total mass.";
			}
            else if (target.tag == "Mercury")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Mercury, the smallest planet in our solar system, is located closest to the Sun. It orbits the Sun at an average distance of about 0.39 astronomical units (AU) and completes a full orbit in just 88 Earth days.";
            }
            else if (target.tag == "Venus")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Venus, often called Earth's sister planet due to its similar size and composition, is the second planet from the Sun, orbiting at an average distance of about 0.72 astronomical units (AU).";
            }
            else if (target.tag == "Earth")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Earth, the third planet from the Sun at an average distance of about 1 astronomical unit (AU), is the only known celestial body to harbor life. With a diverse range of ecosystems and climates, it sustains a rich tapestry of biodiversity. ";
            }
            else if (target.tag == "Saturn")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Saturn, located about 1.4 billion kilometers from the Sun, is the sixth planet in our solar system. Known for its stunning system of rings composed primarily of ice particles, rock debris, and dust, Saturn boasts a diameter of about 116,464 kilometers, making it the second-largest planet in our solar system.";
            }
            else if (target.tag == "Mars")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Mars, the fourth planet from the Sun at an average distance of about 1.5 astronomical units (AU), has captivated scientists and explorers with its rusty surface, earning it the nickname Red Planet. Its thin atmosphere, primarily composed of carbon dioxide, hosts dynamic weather patterns, including dust storms and seasonal polar ice caps.";
            }
            else if (target.tag == "Jupiter")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Jupiter the largest planet in our solar system, is a gas giant composed mainly of hydrogen and helium. Its distance from the Sun is 5.20AU";
            }
            else if (target.tag == "Uranus")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Uranus, the seventh planet from the Sun, orbits at an average distance of about 2.9 billion kilometers, making it the third-largest planet in our solar system. It is a gas giant with a pale blue-green hue due to its atmosphere's high methane content.";
            }
            else if (target.tag == "Neptune")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Neptune, the eighth and farthest planet from the Sun, orbits at an average distance of about 4.5 billion kilometers, making it the fourth-largest planet in our solar system. This ice giant is characterized by its striking blue hue, resulting from the presence of methane in its atmosphere.";
            }
            else if (target.tag == "Cylinder")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Saturn, located about 1.4 billion kilometers from the Sun, is the sixth planet in our solar system. Known for its stunning system of rings composed primarily of ice particles, rock debris, and dust, Saturn boasts a diameter of about 116,464 kilometers, making it the second-largest planet in our solar system.";
            }
            else if (target.tag == "MarsMoon1")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Deimos, the smaller moon of Mars, is also irregularly shaped and heavily cratered. It orbits further from Mars than Phobos, taking about 30 hours to complete one revolution. Like Phobos, Deimos is believed to be composed of a mixture of rock and loose regolith, likely originating as a captured asteroid.";
            }
            else if (target.tag == "MarsMoon2")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "Phobos, the larger of Mars' two moons, is an irregularly shaped body with a heavily cratered surface. It orbits very close to Mars, completing a revolution in just under 8 hours. Phobos is believed to be composed of a mixture of rock and loose regolith, and its origin is thought to be a captured asteroid.";
            }
            else if (target.tag == "Moon")
            {
                Text.GetComponent<TextMeshProUGUI>().text = "The Moon is Earth's only natural satellite, orbiting our planet at an average distance of about 384,400 kilometers. It is the fifth-largest moon in the Solar System and is thought to have formed from debris ejected during a collision between Earth and a Mars-sized body early in the history of the Solar System. The Moon's surface features include impact craters, maria (dark, basaltic plains), and highlands, offering valuable insights into the geological history of both the Moon and Earth.";
            }
            else
            {
                Text.GetComponent<TextMeshProUGUI>().text = null;
            }


            transform.LookAt(target.transform);
        

            
    }
}
