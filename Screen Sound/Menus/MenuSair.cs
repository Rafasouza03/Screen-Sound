﻿using ScreenSound.Menus;
using ScreenSound.Modelos;

namespace Screen_Sound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau thcau :) ");
    }
}
