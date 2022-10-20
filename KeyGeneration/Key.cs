using System;
using System.Collections;
using System.Linq;

namespace CipherSuite.KeyGeneration
{
    internal class Key
    {
        public enum TYPE
        {
            VIGENERE
        }
        public enum PROPERTY
        {
            LOOP_TO_INPUT_LENGTH,
            REVERSE_KEY
        }
        private string key_string = String.Empty;
        public string Value {
            get 
            {
                if (isEnabled(PROPERTY.REVERSE_KEY)) return (string)key_string.Reverse();
                else return key_string;
            } 
            set 
            {
                if ((value.Equals(null)) || (value.Length.Equals(0))) return;
                else key_string = value;
            } 
        }
        public ArrayList properties = new ArrayList();
        public Key (string val)
        {
            this.Value = val;
        }
        public void addProperty(PROPERTY prop)
        {
            properties.Add(prop);
        }
        private bool isEnabled(PROPERTY p)
        {
            if(properties.Count == 0) return false;
            if (properties.Contains(p)) return true;
            else return false;
        }
        public char getCharAt(int index)
        {
            if (isEnabled(PROPERTY.LOOP_TO_INPUT_LENGTH)) return Value[index % Value.Length];
            else return Value[index];
        }
    }
}
