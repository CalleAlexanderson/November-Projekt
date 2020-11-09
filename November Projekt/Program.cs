using System;
using Raylib_cs;

namespace November_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1000, 600, "IDFK");

            Rectangle player = new Rectangle(200, 200, 50, 50);
            int jump = 0;

            while (!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                {
                    Raylib.ToggleFullscreen();
                }

                player.y += 0.2f * jump;

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                {
                    player.y -= 60;

                    if (!Raylib.CheckCollisionRecs(player, floor))
                    {

                    }
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawRectangleRec(player, Color.WHITE);
                Raylib.EndDrawing();


            }
        }
    }
}
