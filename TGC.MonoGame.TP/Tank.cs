﻿using BepuPhysics.Collidables;
using BepuPhysics;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepuPhysics.Constraints;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Input;

namespace ThunderingTanks
{
    public class Tank : GameObject
    {
        Vector3 Direction     = new Vector3(0, 0, 0);
        public float Rotation = 0;
       
        public float TankVelocity { get; set; }
        public float TankRotation { get; set; }

        public Matrix Update(GameTime gameTime, KeyboardState keyboardState, Matrix TankMatrix)
        {
            float time = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (keyboardState.IsKeyDown(Keys.W))
                Direction -= TankMatrix.Forward * TankVelocity * time;

            if (keyboardState.IsKeyDown(Keys.S))
                Direction -= TankMatrix.Backward * TankVelocity * time;

            if (keyboardState.IsKeyDown(Keys.D))
                Rotation -= TankRotation * time;

            if (keyboardState.IsKeyDown(Keys.A))
                Rotation -= -TankRotation * time;

            this.Position = Direction + new Vector3(0, 400f, 0f);

            TankMatrix = Matrix.CreateRotationY(MathHelper.ToRadians(Rotation)) * Matrix.CreateTranslation(Direction);

            return TankMatrix;
        }

    }
}
