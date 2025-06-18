using Interview.Structural.Facade.Subsystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Subsystems.Implementations
{
    public class Projector : IProjector
    {
        private string _contentName;
        private string _inputSource;
        private bool _isOn = false;
        public Projector(string contentName, string inputSource)
        {
            _contentName = contentName;
            _inputSource = inputSource;
        }
        public void DisplayContent(string content)
        {
            if (this._isOn == false)
            {
                TurnOn();
            }
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Content cannot be null or empty.", nameof(content));
            }
            this._contentName = content;
            Console.WriteLine($"Displaying content: {content} on projector with input source: {_inputSource}");
        }

        public void SetInputSource(string source)
        {
            this._inputSource = source;
        }

        public void TurnOff()
        {
            if (string.IsNullOrEmpty(_contentName))
            {
                throw new ArgumentException("Content cannot be null or empty.");
            }
            this._isOn = false;
        }

        public void TurnOn()
        {
            if (string.IsNullOrEmpty(_contentName))
            {
                throw new ArgumentException("Content cannot be null or empty.");
            }
            this._isOn = true;
        }
    }
}
