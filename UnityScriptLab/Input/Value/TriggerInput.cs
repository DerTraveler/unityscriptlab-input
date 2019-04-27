using System;

namespace UnityScriptLab.Input.Value {
  using Provider;

  public class TriggerInput : InputValue<bool> {
    public TriggerInput(string name, ValueProvider<bool> provider) : base(name, provider) { }

    public TriggerInput(string name, Func<InputSystem, bool> getValue) : base(name, getValue) { }

    public TriggerInput(string name) : this(name, _ => false) { }

    public TriggerInput And(TriggerInput other) {
      return new TriggerInput($"{name}+{other.name}", new Combinator<bool, bool, bool>(this, other, (v1, v2) => v1 && v2));
    }
  }
}
