using System;
using System.Collections;
using Microsoft.VisualBasic;
using TurboCollections;

namespace GameStateHistory{
    class program{
        static void Main(){
            var menuOptions = new TurboStack<IEnumerable>();
            
            menuOptions.Push("Quit");
            bool open = true;
            while (open){
                if (menuOptions.Yeet() == "quit"){
                    open = false;
                }
                
            }
        }
    }
}