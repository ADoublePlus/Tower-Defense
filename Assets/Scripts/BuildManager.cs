using UnityEngine;

namespace TowerDefense
{
    public class BuildManager : MonoBehaviour
    {
        public static BuildManager instance;

        public GameObject buildEffect;
        public GameObject sellEffect;

        public NodeUI nodeUI;

        public bool CanBuild { get { return turretToBuild != null; } }
        public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

        private TurretBlueprint turretToBuild;
        private Node selectedNode;

        void Awake ()
        {
            if (instance != null)
            {
                Debug.LogError("More than one BuildManager in scene!");

                return;
            }

            instance = this;
        }

        public void SelectNode (Node node)
        {
            if (selectedNode == node)
            {
                DeselectNode();

                return;
            }

            selectedNode = node;

            turretToBuild = null;

            nodeUI.SetTarget(node);
        }

        public void DeselectNode ()
        {
            selectedNode = null;

            nodeUI.Hide();
        }

        public void SelectTurretToBuild (TurretBlueprint turret)
        {
            turretToBuild = turret;

            DeselectNode();
        }

        public TurretBlueprint GetTurretToBuild ()
        {
            return turretToBuild;
        }
    }
}