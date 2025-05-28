using System;

namespace Commandos
{

    // Access control interface
    public interface IIdentifiable
    {
        string SayName(string commanderRank);
    }
}
