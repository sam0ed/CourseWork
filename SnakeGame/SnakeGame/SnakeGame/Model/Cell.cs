﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Model
{
    internal class Cell : INotifyPropertyChanged
    {
        #region Fields
        private CellTypes cellType;
        #endregion

        #region Constructors
        public Cell(CellTypes cellType, int RowCoord, int ColCoord)
        {
            CellType = cellType;
            this.RowCoord = RowCoord;
            this.ColCoord = ColCoord;
        }
        #endregion

        #region Properties
        public CellTypes CellType
        {
            get => cellType;
            set
            {
                cellType = value;
                OnPropertyChanged(nameof(CellType));
            }
        }

        public int ColCoord { get; set; }
        public int RowCoord { get; set; }
        #endregion

        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region Handlers
        protected void OnPropertyChanged(string propertyName)
        {
              PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Methods
        #endregion
    }
    enum CellTypes
    {
        EmptyCell,
        FoodCell,
        SnakeCell,
    }
}
