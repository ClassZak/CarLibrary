﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarLibrary
{
    // Представляет состояние двигателя.
    public enum EngineState { engineAlive, engineDead }
    // Абстрактный базовый класс в иерархии.
    public abstract class Car
    {
        public enum MusicMedia//Типы музыки
        {
            musicCd, // 0
            musicTape, // 1
            musicRadio, // 2
            musicMp3 // 3
        }


        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }

        public abstract void TurboBoost();



        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState egnState = EngineState.engineAlive;
        public EngineState EngineState
        {
            get { return egnState; }
        }
        public void TurnOnRadio(bool musicOn, MusicMedia mm)
        {
            if (musicOn) MessageBox.Show(string.Format("Jamming {0}", mm));
            else MessageBox.Show("Quiet time...");
        }

    }
}
