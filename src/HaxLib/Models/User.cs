﻿namespace HaxLib.Models
{
    public sealed class User
    {
        public User(int id, string name, bool verified, int? lobbyid, float? payamount)
        {
            this.ID = id;
            this.Name = name;
            this.Verified = verified;
            this.LobbyID = lobbyid;
            this.PayAmount = payamount;
        }

        public int ID { get; private set; }

        public string Name { get; private set; }

        public bool Verified { get; private set; }

        public int? LobbyID { get; private set; }

        public float? PayAmount { get; private set; }

        public void Reset()
        {
            this.PayAmount = null;
            this.LobbyID = null;
        }
    }
}
