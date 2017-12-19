using System;

namespace DesignPatterns.Operation.Memento
{
    public class ConstraintSolverMemento
    {
        private ConstraintSolverState _state;

        public ConstraintSolverMemento(ConstraintSolverState state)
        {
            _state = state;
        }

        internal ConstraintSolverState GetState()
        {
            throw new NotImplementedException();
        }
    }
}
