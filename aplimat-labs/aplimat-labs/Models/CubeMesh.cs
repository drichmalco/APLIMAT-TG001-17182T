using aplimat_labs.NewFolder1;
using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplimat_labs.Models
{
    public class CubeMesh : Movable
    {
        public Vector3 Position;

        public CubeMesh()
        {
            this.Position = new Vector3();
        }
        public CubeMesh(Vector3 initPos)
        {
            this.Position = initPos;
        }
        public CubeMesh(float x, float y, float z)
        {
            this.Position = new Vector3(x, y, z);
        }
        public void Draw(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
            // Top
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);

            //Right
            gl.Vertex(this.Position.x + 0.5f, this.Position.y + 0.5f, this.Position.z - 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y - 0.5f, this.Position.z - 0.5f);
            //Left
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z - 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z - 0.5f);
            //Back
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.End();

            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.End();

            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x - 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y + 0.5f, this.Position.z + 0.5f);
            gl.Vertex(this.Position.x + 0.5f, this.Position.y - 0.5f, this.Position.z + 0.5f);
            gl.End();

            UpdateMotion();
        }
        private void UpdateMotion()
        {
            this.Velocity += this.Acceleration;
            this.Position += this.Velocity;
            this.Acceleration *= 0;
        }
    }
}
