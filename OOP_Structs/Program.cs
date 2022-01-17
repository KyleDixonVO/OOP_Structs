using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Structs
{
    class Program
    {

        struct Vector2
        {
           public float x;
           public float y;
        }

        struct Vector3
        {
            public float x;
            public float y;
            public float z;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Structs:");
            Console.WriteLine("");

            // purpose:
            // reading in gamepad intput (left stick) -- (x,y)
            // 

            Console.WriteLine("BEFORE STRUCTS:");
            Console.WriteLine("");

            // gamepad
            float gamepadX; // -1.0..1.0
            float gamepadY; // -1.0..1.0

            gamepadX = 0.0f; //would be in it's own method
            gamepadY = 0.0f; //would be in it's own method

            //player movement (3d)
            float playerMovementX;
            float playerMovementY;
            float playerMovementZ;

            playerMovementX = gamepadX;
            playerMovementY = 0.0f;
            playerMovementZ = gamepadY;


            Console.WriteLine("AFTER STRUCTS:");
            Console.WriteLine("");

            Vector2 gamepad;
            Vector3 playerMovement;

            gamepad = ReadGamepadInput();
            playerMovement.x = gamepad.x;
            playerMovement.x = 0.0f;
            playerMovement.z = gamepad.y;
            
            
            
            
            Console.ReadKey(true);

        }

        static Vector2 ReadGamepadInput()
        {
            Vector2 output;
            output.x = 0.0f;
            output.y = 0.0f;
            return output;
        }
    }
}
