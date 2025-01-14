﻿using System.ComponentModel;

namespace StoneDesafio.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ClubeAId { get; set; }
        [Description("Clube A")]
        public virtual Clube ClubeA { get; set; }
        public int ClubeBId { get; set; }
        [Description("Clube B")]
        public virtual Clube ClubeB { get; set; }
        public int GolsA { get; set; }
        public int GolsB { get; set; }
        public DateTime InicioJogo { get; set; }

        public virtual Resultado Resultado { get; set; }

        public int FaseId { get; set; }
        public virtual FaseCampeonato Fase { get; set; }
    }
}
