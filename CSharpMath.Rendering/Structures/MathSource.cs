using CSharpMath.Atoms;

namespace CSharpMath.Rendering {
  public readonly struct MathSource : ISource {
    public MathSource(string latex) {
      (MathList, ErrorMessage) = MathListBuilder.TryMathListFromLaTeX(latex);
      LaTeX = latex;
    }
    public MathSource(MathList mathList) {
      LaTeX = MathListBuilder.MathListToLaTeX(mathList);
      MathList = mathList;
      ErrorMessage = null;
    }
    public MathList MathList { get; }
    public string LaTeX { get; }
    public string ErrorMessage { get; }
    public bool IsValid => MathList != null;
  }
}
