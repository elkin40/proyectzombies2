using System;

public enum BodyParts
{
    Cabeza,
    Brazos,
    Piernas,
    Manos,
    Cerebro,
}

public enum Behaviour
{
    Idle,
    Moving
}

public struct InfoZombie
{
    public string color;
    public BodyParts favPart;
    public Behaviour behaviour;
    public BodyParts partescorp;
} 



