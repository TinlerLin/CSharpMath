using System;
using System.Collections.Generic;
using System.Text;
using CSharpMath.Enumerations;

namespace CSharpMath.Atoms.Atom {
  /// <summary>Close brackets</summary>
  public class Close : MathAtom {
    public Close(string nucleus) : base(MathAtomType.Close, nucleus) { }
    public override bool ScriptsAllowed => true;
    public new Close Clone(bool finalize) => (Close)base.Clone(finalize);
    protected override MathAtom CloneInside(bool finalize) => new Close(Nucleus);
  }
}
