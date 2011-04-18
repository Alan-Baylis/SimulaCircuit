﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimulaCircuit.GUI.Data
{
    [Serializable]
    public class CustomCircuit : XmlSerializable<CustomCircuit>
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Description { get; set; }

        [XmlArray]
        public List<IOutput> Items { get; set; }

        public CustomCircuit(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
