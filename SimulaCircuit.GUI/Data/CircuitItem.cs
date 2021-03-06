﻿using System;
using System.Windows.Controls;
using System.Xml.Serialization;
using WPF.JoshSmith.Controls;

namespace SimulaCircuit.GUI.Data
{
    [Serializable]
    public class CircuitItem<T> : InputsOutput, IXmlSerializable<CircuitItem<T>> where T : InputsOutput
    {
        [XmlAttribute]
        public double Left
        {
            get { return DragCanvas.GetLeft(Canvas); }
            set { DragCanvas.SetLeft(Canvas, value); }
        }

        [XmlAttribute]
        public double Top
        {
            get { return DragCanvas.GetTop(Canvas); }
            set { DragCanvas.SetTop(Canvas, value); }
        }

        [XmlAttribute]
        public string ItemType { get; set; }

        public Canvas Canvas;
        private T item;


        public override bool this[int i]
        {
            get { return item[i]; }
        }

        public override IInputsOutput[] Inputs
        {
            get { return item.Inputs; }
            set { item.Inputs = value; }
        }

        public ulong Id
        {
            get { return item.Id; }
        }


        public CircuitItem(DragCanvas dc, T item)
        {
            this.item = item;
            Canvas = new Canvas();
            dc.Children.Add(Canvas);
        }
    }
}
