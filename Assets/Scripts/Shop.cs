using UnityEngine;

namespace TowerDefense
{
    public class Shop : MonoBehaviour
    {
        BuildManager buildManager;

        public TurretBlueprint standardTurret;
        public TurretBlueprint missileLauncher;
        public TurretBlueprint laserBeamer;

        // Use this for initialization
        void Start ()
        {
            buildManager = BuildManager.instance;
        }

        public void SelectStandardTurret ()
        {
            Debug.Log("Standard Turret Selected");

            buildManager.SelectTurretToBuild(standardTurret);
        }

        public void SelectMissileLauncher ()
        {
            Debug.Log("Missile Launcher Selected");

            buildManager.SelectTurretToBuild(missileLauncher);
        }

        public void SelectLaserBeamer ()
        {
            Debug.Log("Laser Beamer Selected");

            buildManager.SelectTurretToBuild(laserBeamer);
        }
    }
}