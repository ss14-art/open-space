using Content.Shared.Humanoid.Prototypes;
using Content.Shared.Preferences;
using Content.Shared._OpenSpace.TTS; // OpenSpace-TTS
using Robust.Shared.Enums;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Humanoid;

/// <summary>
/// Dictates what species and age this character "looks like"
/// </summary>
[NetworkedComponent, RegisterComponent, AutoGenerateComponentState(true)]
[Access(typeof(HumanoidProfileSystem))]
public sealed partial class HumanoidProfileComponent : Component
{
    [DataField, AutoNetworkedField]
    public Gender Gender;

    [DataField, AutoNetworkedField]
    public Sex Sex;

    [DataField, AutoNetworkedField]
    public int Age = 18;

    [DataField, AutoNetworkedField]
    public ProtoId<SpeciesPrototype> Species = HumanoidCharacterProfile.DefaultSpecies;

    // OpenSpace-TTS Start
    /// <summary>
    ///     Current voice. Used for correct cloning.
    /// </summary>
    [DataField("voice")]
    public ProtoId<TTSVoicePrototype> Voice { get; set; } = HumanoidCharacterProfile.DefaultVoice; // HumanoidCharacterProfile
    // OpenSpace-TTS End
}
