using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Operation.Memento
{
    public class MoveCommand
    {
        private ConstraintSolverMemento _state;

        private Constraint _constraint;

        public MoveCommand(Constraint constraint)
        {
            this._constraint = constraint;
        }

        public void Execute()
        {
            ConstraintSolver solver = new ConstraintSolver();
            this._state = solver.CreateMemento(); // create state memento

            Constraint newConstraint = new Constraint();

            solver.AddConstraint(_constraint);

            solver.Solve();
        }

        public void UnExecute()
        {
            ConstraintSolver solver = new ConstraintSolver();
            solver.RemoveConstraint(_constraint);
            solver.SetMemento(_state); // restore the state
            solver.Solve();
        }
    }
}
