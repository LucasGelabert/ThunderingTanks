﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using ThunderingTanks.Cameras;


namespace ThunderingTanks.Objects
{
    public class GameObject
    {
        public Model GameModel { get; set; }
        public Vector3 Position { get; set; }
        public bool IsActive { get; set; }
        public BoundingSphere BoundingSphere { get; set; }

        public BoundingBox BoundingBox { get; set; }

        public GameObject()
        {
            GameModel = null;
            Position = Vector3.Zero;
            IsActive = false;
            BoundingSphere = new BoundingSphere();
        }

    }
}
