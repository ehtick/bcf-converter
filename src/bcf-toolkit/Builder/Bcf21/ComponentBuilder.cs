using BcfToolkit.Model;
using BcfToolkit.Model.Bcf21;

namespace BcfToolkit.Builder.Bcf21;

public class ComponentBuilder :
  IComponentBuilder<ComponentBuilder>,
  IDefaultBuilder<ComponentBuilder> {
  private readonly Component _component = new();

  public ComponentBuilder SetIfcGuid(string guid) {
    _component.IfcGuid = guid;
    return this;
  }

  public ComponentBuilder SetOriginatingSystem(string system) {
    _component.OriginatingSystem = system;
    return this;
  }

  public ComponentBuilder SetAuthoringToolId(string id) {
    _component.AuthoringToolId = id;
    return this;
  }

  public ComponentBuilder WithDefaults() {
    this.SetIfcGuid("123456789abcdef1234567");
    return this;
  }

  public IComponent Build() {
    return BuilderUtils.ValidateItem(_component);
  }
}