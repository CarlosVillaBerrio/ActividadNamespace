namespace NPC
{
    namespace Ally
    {
        using UnityEngine;
        public struct VillagerStruct
        {
            // Datos del aldeano
            public enum nombresAldeano
            {
                Alex, Bernardo, Carlos, David, Fernando, Gustavo, Jose, Maria, Jesus, Pedro,
                Camilo, Alberto, Leon, John, Camila, Layla, Emily, Claire, Marta, Sofia
            };
            public nombresAldeano nombreAldeano;
            public int edadAldeano;
        }
        public class MyVillager : MonoBehaviour
        {
            public VillagerStruct datosAldeano;
            void Awake()
            {
                datosAldeano.nombreAldeano = (VillagerStruct.nombresAldeano)Random.Range(0, 20); // SELECTOR DE NOMBRES
                datosAldeano.edadAldeano = Random.Range(15, 101); // SELECTOR DE EDAD
            }
        }
    }
}