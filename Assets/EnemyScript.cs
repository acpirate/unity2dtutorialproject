

using UnityEngine;

/// <summary>
/// Enemy generic behavior
/// </summary>
public class EnemyScript : MonoBehaviour
{
	private WeaponScript[] weapon;
	
	void Awake()
	{
		// Retrieve the weapon only once
		weapon = GetComponentsInChildren<WeaponScript>();
	}
	
	void Update()
	{
		// Auto-fire
		if (weapon != null && weapon.CanAttack)
		{
			weapon.Attack(true);
		}
	}
}
