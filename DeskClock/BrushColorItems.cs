using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DeskClock
{
    public class BrushColorItems : ObservableCollection<BrushColor>
    {

        public BrushColorItems()
        {
            Add(new BrushColor(Brushes.Transparent, "Transperent"));
            Add(new BrushColor(Brushes.Black, "Black"));
            Add(new BrushColor(Brushes.White, "White"));
            Add(new BrushColor(Brushes.Blue, "Blue"));
            Add(new BrushColor(Brushes.Red, "Red"));
            Add(new BrushColor(Brushes.Green, "Green"));
            Add(new BrushColor(Brushes.AliceBlue, "Alice Blue"));
            Add(new BrushColor(Brushes.AntiqueWhite, "Antique White"));
            Add(new BrushColor(Brushes.Aqua, "Aqua"));
            Add(new BrushColor(Brushes.Aquamarine, "Aquamarine"));
            Add(new BrushColor(Brushes.Azure, "Azure"));
            Add(new BrushColor(Brushes.Beige, "Beige"));
            Add(new BrushColor(Brushes.Bisque, "Bisque"));
            Add(new BrushColor(Brushes.BlanchedAlmond, "Blanched Almond"));
            Add(new BrushColor(Brushes.BlueViolet, "Blue Violet"));
            Add(new BrushColor(Brushes.Brown, "Brown"));
            Add(new BrushColor(Brushes.BurlyWood, "BurlyWood"));
            Add(new BrushColor(Brushes.CadetBlue, "Cadet Blue"));
            Add(new BrushColor(Brushes.Chartreuse, "Chartreuse"));
            Add(new BrushColor(Brushes.Chocolate, "Chocolate"));
            Add(new BrushColor(Brushes.Coral, "Coral"));
            Add(new BrushColor(Brushes.CornflowerBlue, "Cornflower Blue"));
            Add(new BrushColor(Brushes.Cornsilk, "Cornsilk"));
            Add(new BrushColor(Brushes.Crimson, "Crimson"));
            Add(new BrushColor(Brushes.Cyan, "Cyan"));
            Add(new BrushColor(Brushes.DarkBlue, "Dark Blue"));
            Add(new BrushColor(Brushes.DarkCyan, "Dark Cyan"));
            Add(new BrushColor(Brushes.DarkGoldenrod, "Dark Goldenrod"));
            Add(new BrushColor(Brushes.DarkGray, "Dark Gray"));
            Add(new BrushColor(Brushes.DarkGreen, "Dark Green"));
            Add(new BrushColor(Brushes.DarkKhaki, "Dark Khaki"));
            Add(new BrushColor(Brushes.DarkMagenta, "Dark Magenta"));
            Add(new BrushColor(Brushes.DarkOliveGreen, "Dark Olive Green"));
            Add(new BrushColor(Brushes.DarkOrange, "Dark Orange"));
            Add(new BrushColor(Brushes.DarkOrchid, "Dark Orchid"));
            Add(new BrushColor(Brushes.DarkRed, "Dark Red"));
            Add(new BrushColor(Brushes.DarkSalmon, "Dark Salmon"));
            Add(new BrushColor(Brushes.DarkSeaGreen, "Dark Sea Green"));
            Add(new BrushColor(Brushes.DarkSlateBlue, "Dark Slate Blue"));
            Add(new BrushColor(Brushes.DarkSlateGray, "Dark Slate Gray"));
            Add(new BrushColor(Brushes.DarkSlateGray, "Dark Slate Gray"));
            Add(new BrushColor(Brushes.DarkTurquoise, "Dark Turquoise"));
            Add(new BrushColor(Brushes.DarkViolet, "Dark Violet"));
            Add(new BrushColor(Brushes.DeepPink, "Deep Pink"));
            Add(new BrushColor(Brushes.DeepSkyBlue, "Deep Sky Blue"));
            Add(new BrushColor(Brushes.DimGray, "Dim Gray"));
            Add(new BrushColor(Brushes.DodgerBlue, "Dodger Blue"));
            Add(new BrushColor(Brushes.Firebrick, "Firebrick"));
            Add(new BrushColor(Brushes.FloralWhite, "Floral White"));
            Add(new BrushColor(Brushes.ForestGreen, "Forest Green"));
            Add(new BrushColor(Brushes.Fuchsia, "Fuchsia"));
            Add(new BrushColor(Brushes.Gainsboro, "Gainsboro"));
            Add(new BrushColor(Brushes.GhostWhite, "Ghost White"));
            Add(new BrushColor(Brushes.Gold, "Gold"));
            Add(new BrushColor(Brushes.Goldenrod, "Goldenrod"));
            Add(new BrushColor(Brushes.Gray, "Gray"));
            Add(new BrushColor(Brushes.GreenYellow, "GreenYellow"));
            Add(new BrushColor(Brushes.Honeydew, "Honeydew"));
            Add(new BrushColor(Brushes.HotPink, "HotPink"));
            Add(new BrushColor(Brushes.IndianRed, "IndianRed"));
            Add(new BrushColor(Brushes.Indigo, "Indigo"));
            Add(new BrushColor(Brushes.Ivory, "Ivory"));
            Add(new BrushColor(Brushes.Khaki, "Khaki"));
            Add(new BrushColor(Brushes.Lavender, "Lavender"));
            Add(new BrushColor(Brushes.LavenderBlush, "Lavender Blush"));
            Add(new BrushColor(Brushes.LawnGreen, "Lawn Green"));
            Add(new BrushColor(Brushes.LemonChiffon, "Lemon Chiffon"));
            Add(new BrushColor(Brushes.LightBlue, "Light Blue"));
            Add(new BrushColor(Brushes.LightCoral, "Light Coral"));
            Add(new BrushColor(Brushes.LightCyan, "Light Cyan"));
            Add(new BrushColor(Brushes.LightGoldenrodYellow, "Light Goldenrod Yellow"));
            Add(new BrushColor(Brushes.LightGray, "Light Gray"));
            Add(new BrushColor(Brushes.LightGreen, "Light Green"));
            Add(new BrushColor(Brushes.LightPink, "Light Pink"));
            Add(new BrushColor(Brushes.LightSalmon, "Light Salmon"));
            Add(new BrushColor(Brushes.LightSeaGreen, "Light Sea Green"));
            Add(new BrushColor(Brushes.LightSkyBlue, "Light Sky Blue"));
            Add(new BrushColor(Brushes.LightSlateGray, "Light Slate Gray"));
            Add(new BrushColor(Brushes.LightSteelBlue, "Light Steel Blue"));
            Add(new BrushColor(Brushes.LightYellow, "Light Yellow"));
            Add(new BrushColor(Brushes.Lime, "Lime"));
            Add(new BrushColor(Brushes.LimeGreen, "Lime Green"));
            Add(new BrushColor(Brushes.Linen, "Linen"));
            Add(new BrushColor(Brushes.Magenta, "Magenta"));
            Add(new BrushColor(Brushes.Maroon, "Maroon"));
            Add(new BrushColor(Brushes.MediumAquamarine, "Medium Aquamarine"));
            Add(new BrushColor(Brushes.MediumBlue, "Medium Blue"));
            Add(new BrushColor(Brushes.MediumOrchid, "Medium Orchid"));
            Add(new BrushColor(Brushes.MediumPurple, "Medium Purple"));
            Add(new BrushColor(Brushes.MediumSeaGreen, "Medium Sea Green"));
            Add(new BrushColor(Brushes.MediumSlateBlue, "Medium Slate Blue"));
            Add(new BrushColor(Brushes.MediumSpringGreen, "Medium Spring Green"));
            Add(new BrushColor(Brushes.MediumTurquoise, "Medium Turquoise"));
            Add(new BrushColor(Brushes.MediumVioletRed, "Medium Violet Red"));
            Add(new BrushColor(Brushes.MidnightBlue, "Midnight Blue"));
            Add(new BrushColor(Brushes.MintCream, "Mint Cream"));
            Add(new BrushColor(Brushes.MistyRose, "Misty Rose"));
            Add(new BrushColor(Brushes.Moccasin, "Moccasin"));
            Add(new BrushColor(Brushes.NavajoWhite, "Navajo White"));
            Add(new BrushColor(Brushes.Navy, "Navy"));
            Add(new BrushColor(Brushes.OldLace, "Old Lace"));
            Add(new BrushColor(Brushes.Olive, "Olive"));
            Add(new BrushColor(Brushes.OliveDrab, "Olive Drab"));
            Add(new BrushColor(Brushes.Orange, "Orange"));
            Add(new BrushColor(Brushes.OrangeRed, "OrangeRed"));
            Add(new BrushColor(Brushes.Orchid, "Orchid"));
            Add(new BrushColor(Brushes.PaleGoldenrod, "Pale Goldenrod"));
            Add(new BrushColor(Brushes.PaleGreen, "Pale Green"));
            Add(new BrushColor(Brushes.PaleTurquoise, "Pale Turquoise"));
            Add(new BrushColor(Brushes.PaleVioletRed, "Pale Violet Red"));
            Add(new BrushColor(Brushes.PapayaWhip, "Papaya Whip"));
            Add(new BrushColor(Brushes.PeachPuff, "Peach Puff"));
            Add(new BrushColor(Brushes.Peru, "Peru"));
            Add(new BrushColor(Brushes.Pink, "Pink"));
            Add(new BrushColor(Brushes.Plum, "Plum"));
            Add(new BrushColor(Brushes.PowderBlue, "Powder Blue"));
            Add(new BrushColor(Brushes.Purple, "Purple"));
            Add(new BrushColor(Brushes.RosyBrown, "Rosy Brown"));
            Add(new BrushColor(Brushes.RoyalBlue, "Royal Blue"));
            Add(new BrushColor(Brushes.SaddleBrown, "Saddle Brown"));
            Add(new BrushColor(Brushes.Salmon, "Salmon"));
            Add(new BrushColor(Brushes.SandyBrown, "Sandy Brown"));
            Add(new BrushColor(Brushes.SeaGreen, "Sea Green"));
            Add(new BrushColor(Brushes.SeaShell, "Sea Shell"));
            Add(new BrushColor(Brushes.Sienna, "Sienna"));
            Add(new BrushColor(Brushes.Silver, "Silver"));
            Add(new BrushColor(Brushes.SkyBlue, "Sky Blue"));
            Add(new BrushColor(Brushes.SlateBlue, "Slate Blue"));
            Add(new BrushColor(Brushes.SlateGray, "Slate Gray"));
            Add(new BrushColor(Brushes.Snow, "Snow"));
            Add(new BrushColor(Brushes.SpringGreen, "Spring Green"));
            Add(new BrushColor(Brushes.SteelBlue, "Steel Blue"));
            Add(new BrushColor(Brushes.Tan, "Tan"));
            Add(new BrushColor(Brushes.Teal, "Teal"));
            Add(new BrushColor(Brushes.Thistle, "Thistle"));
            Add(new BrushColor(Brushes.Tomato, "Tomato"));
            Add(new BrushColor(Brushes.Turquoise, "Turquoise"));
            Add(new BrushColor(Brushes.Violet, "Violet"));
            Add(new BrushColor(Brushes.WhiteSmoke, "White Smoke"));
            Add(new BrushColor(Brushes.Yellow, "Yellow"));
            Add(new BrushColor(Brushes.YellowGreen, "Yellow Green"));

        }


        public BrushColor GetBrushColor(String name)
        {
            foreach (BrushColor bc in this)
            {
                
                if (bc.Name == name) return bc;
            }
            return null;

        }

    }
}
