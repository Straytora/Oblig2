﻿using System;

namespace SimpleChess
{
    abstract class Piece
    {
        public string Symbol { get; set; }

        protected Piece()
        {
            Symbol = Symbol;
        }

        public abstract bool Move(string fromPosition, string toPosition);
    }
}
