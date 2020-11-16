using System;
using Raylib_cs;

namespace November_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1000, 600, "IDFK");
            Raylib.SetTargetFPS(60);

            Rectangle player = new Rectangle(200, 200, 50, 50);
            float gravity = 1f;
            bool touchingFLoor = false;
            Rectangle floor = new Rectangle(0, 500, 1000, 100);

            while (!Raylib.WindowShouldClose())
            {

                if (Raylib.CheckCollisionRecs(player, floor))
                {
                    touchingFLoor = true;
                }
                else
                {
                    touchingFLoor = false;
                }

                player.y += gravity;
                if (!touchingFLoor)
                {
                    gravity = gravity * 1.06f;
                }
                else
                {
                    gravity = 0f;
                }

                if (touchingFLoor && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                {
                    gravity = -1;
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawRectangleRec(floor, Color.WHITE);
                Raylib.DrawRectangleRec(player, Color.WHITE);
                Raylib.EndDrawing();


            }
        }
    }
}
