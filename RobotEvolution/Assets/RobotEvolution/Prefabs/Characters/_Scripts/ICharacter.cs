using UnityEngine;

public interface ICharacter
{
    public float Scale { get; }
    public string Nickname { get; set; }
    public int IndexPositionInLIderBoard { get; set; }

    //public void StartDeath(Vector3 killerPosition);
    //public void RefreshCharacterData();

    //public void AddScaleCharacter(float amount);
    //public void LossScaleCharacter(float amount);
}