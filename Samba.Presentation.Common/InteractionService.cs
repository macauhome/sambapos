﻿using System;

namespace Samba.Presentation.Common
{
    public static class InteractionService
    {
        public static IUserInteraction UserIntraction { get; set; }

        public static void ShowKeyboard()
        {
            UserIntraction.ShowKeyboard();
        }

        public static void HideKeyboard()
        {
            UserIntraction.HideKeyboard();
        }

        public static void ToggleKeyboard()
        {
            UserIntraction.ToggleKeyboard();
        }
    }
}
