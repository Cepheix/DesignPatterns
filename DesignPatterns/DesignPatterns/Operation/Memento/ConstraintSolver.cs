namespace DesignPatterns.Operation.Memento
{
    public class ConstraintSolver
    {
        private ConstraintSolverState _state;

        public void AddConstraint(Constraint constraint)
        {

        }

        public void RemoveConstraint(Constraint constraint)
        {

        }

        public ConstraintSolverMemento CreateMemento()
        {
            return new ConstraintSolverMemento(this._state);
        }

        public void Solve()
        {
        }

        public void SetMemento(ConstraintSolverMemento memento)
        {
            this._state = memento.GetState();
        }
    }
}
