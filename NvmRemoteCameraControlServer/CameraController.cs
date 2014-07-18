using PTZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NvmRemoteCameraControlServer
{
    [EnableCors("*", "*", "GET")]
    public class CameraController : ApiController
    {
        const string DeviceName = "ConferenceCam CC3000e Camera";
        PTZDevice _myCamera;

        public CameraController()
        {
            _myCamera = PTZDevice.GetDevice(DeviceName, PTZType.Relative);
        }

        

        
        //public string Get()
        //{
        //    return "Hello, world!";
        //}

        //[HttpPost]
        [HttpGet]
        [ActionName("moveleft")]
        public void MoveLeft()
        {
            _myCamera.Move(-5, 0);
            Console.WriteLine("move left");
        }

        [HttpGet]
        [ActionName("moveright")]
        public void MoveRight()
        {
            _myCamera.Move(5, 0);
            Console.WriteLine("move right");
        }

        [HttpGet]
        [ActionName("moveup")]
        public void MoveUp()
        {
            _myCamera.Move(0, 5);
            Console.WriteLine("move up");
        }

        [HttpGet]
        [ActionName("movedown")]
        public void MoveDown()
        {
            _myCamera.Move(0, -5);
            Console.WriteLine("move down");
        }


        [HttpGet]
        [ActionName("zoomin")]
        public void ZoomIn()
        {
            _myCamera.Zoom(5);
            Console.WriteLine("zoom in");
        }

        [HttpGet]
        [ActionName("zoomout")]
        public void ZoomOut()
        {
            _myCamera.Zoom(-5);
            Console.WriteLine("zoom out");
        }

        [HttpGet]
        [ActionName("swingleft")]
        public void SwingLeft()
        {
            _myCamera.Move(-50, 0);
            Console.WriteLine("swing left");
        }

        [HttpGet]
        [ActionName("swingright")]
        public void SwingRight()
        {
            _myCamera.Move(50, 0);
            Console.WriteLine("swing right");
        }

        [HttpGet]
        [ActionName("swingup")]
        public void SwingUp()
        {
            _myCamera.Move(0, 50);
            Console.WriteLine("swing up");
        }

        [HttpGet]
        [ActionName("swingdown")]
        public void SwingDown()
        {
            _myCamera.Move(0, -50);
            Console.WriteLine("swing down");
        }

        [HttpGet]
        [ActionName("nudgeleft")]
        public void NudgeLeft()
        {
            _myCamera.Move(-1, 0);
            Console.WriteLine("nudge left");
        }

        [HttpGet]
        [ActionName("nudgeright")]
        public void NudgeRight()
        {
            _myCamera.Move(1, 0);
            Console.WriteLine("nudge right");
        }

        [HttpGet]
        [ActionName("nudgeup")]
        public void NudgeUp()
        {
            _myCamera.Move(0, 1);
            Console.WriteLine("Nudge up");
        }

        [HttpGet]
        [ActionName("nudgedown")]
        public void NudgeDown()
        {
            _myCamera.Move(0, -1);
            Console.WriteLine("nudge down");
        }

        
    }
}
