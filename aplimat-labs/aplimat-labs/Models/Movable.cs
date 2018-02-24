using aplimat_labs.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplimat_labs.Models
{
    public class Movable
    {
        public Vector3 Position;
        public Vector3 Velocity;
        public Vector3 Acceleration;
        public float Mass = 1;


        public Movable()
        {
            this.Position = new Vector3();
            this.Acceleration = new Vector3();
            this.Velocity = new Vector3();
        }
        public void ApplyForce(Vector3 force)
        {
            // F = MA
            // A = F/M
            this.Acceleration += (force / Mass)
;       }
        public void ApplyGravity(Vector3 gravity)
        {
            // F = MA
            // A = F/M
            this.Acceleration += (gravity * Mass)
;
        }
        public void Bounce(Vector3 bounce)
        {
            // F = MA
            // A = F/M
            this.Acceleration += (bounce * Mass)
;
        }
    }
}
