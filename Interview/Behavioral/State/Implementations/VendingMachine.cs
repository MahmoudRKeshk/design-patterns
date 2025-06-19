using Interview.Behavioral.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.State.Implementations
{
    public class VendingMachine
    {
        public IVendingMachineState _idleState { get; private set; }
        public IVendingMachineState _hasMoneyState { get; private set; }
        public IVendingMachineState _dispensingState { get; private set; }

        private IVendingMachineState _currentState;
        public VendingMachine()
        {
            _idleState = new IdleState(this);
            _hasMoneyState = new HasMoneyState(this);
            _dispensingState = new DispensingState(this);
            
            _currentState = _idleState;
        }

        public void SetState(IVendingMachineState state)
        {
            _currentState = state;
        }   

        public IVendingMachineState GetState()
        {
            return this._currentState;
        }

        public void Cancel()
        {
            this._currentState.Cancel();
        }

        public void InsertMoney()
        {
            this._currentState.InsertMoney();
        }

        public void DispenseItem()
        {
            this._currentState.DispenseItem();
        }
    }
}
