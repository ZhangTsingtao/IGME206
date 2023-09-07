﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Monster
    {
        private string m_sNickname = "";
        private int m_nLevel = 1;
        private float m_fHP = 10.0f;
        private float m_fAttack = 1.0f;
        private float m_fDefense = 1.0f;
        private string m_sType = "Normal";

        public Monster(string a_sNickname)
        {
            Init(a_sNickname, 1);
        }
        public Monster(string a_sNickname, int a_nLevel) 
        {
            Init(a_sNickname, a_nLevel);
        }
        protected void Init(string a_sNickname, int a_nLevel)
        {
            m_sNickname = a_sNickname;
            m_nLevel = a_nLevel;
            m_fHP += m_nLevel;
            m_fAttack += m_nLevel;
            m_fDefense += m_nLevel;
            m_sType = "Normal";
        }
        
        public int Level
        {
            get { return m_nLevel; }
        }
        public string Nickname {  get { return m_sNickname; } }
        public float HP { get { return m_fHP; } }
        public float Attack { get { return m_fAttack; } }
        public float Defense { get {  return m_fDefense; } }
        public string Type { get { return m_sType; } }

        public void Fight(Monster a_monster)
        {
            this.Fight(a_monster.Attack);
        }

        protected void Fight(float a_fIncomingDamage)
        {
            float fCombatResult = m_fDefense - a_fIncomingDamage;
            if (fCombatResult < 0)
            {
                m_fHP += fCombatResult;
            }
        }

        public void Print()
        {
            Console.WriteLine("Monster name: " + Nickname);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Attack: " + Attack);
            Console.WriteLine("Defense: " + Defense);
            Console.WriteLine("");
        }
    }
}