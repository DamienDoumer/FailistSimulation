using System;
using System.Collections.Generic;
using System.Threading;
using FailistSimulation.Models;

namespace FailistSimulation.Services
{
    public class Simulator
    {
        private const int MAXERRORCOUNT = 10;
        public List<IdFailureX> FailureXes { get; set; }
        public IdPlane Plane { get; set; }
        public double SecondsDuration { get; set; }
        public int TimeFrame { get; set; }
        public TypePlane PlaneType { get; set; }
        public event Action<IdPlane, IdFailureX, TypePlane, IdComponentFailureX> ErrorOccured;
        public event Action SimulationFinished;
        Thread _thread;

        public Simulator(List<IdFailureX> idFailureXes, IdPlane idPlane, double seconds, int timeFrame)
        {
            var failistObject = DataAccessor.DeserializeData();
            TimeFrame = timeFrame;
            Plane = idPlane;
            PlaneType = failistObject.TypePlane[new Random().Next(0, failistObject.TypePlane.Length)];
            FailureXes = idFailureXes;
            SecondsDuration = seconds;
            TimeFrame = timeFrame;
        }

        public Simulator(double seconds, int timeFrame)
        {
            var failistObject = DataAccessor.DeserializeData();
            Plane = failistObject.IdPlanes[new Random().Next(0, failistObject.IdPlanes.Length)];
            PlaneType = failistObject.TypePlane[new Random().Next(0, failistObject.TypePlane.Length)];
            SecondsDuration = seconds;
            TimeFrame = timeFrame;
            FailureXes = new List<IdFailureX>(failistObject.IdFailureX);
        }

        public void Stop()
        {
            _thread.Suspend();
        }

        public void Simulate()
        {
            var failObj = DataAccessor.DeserializeData();
            var duration = Decimal.Divide(new Decimal(SecondsDuration), new Decimal(TimeFrame));
            
                _thread = new Thread(() =>
                {
                    for (int i = 0; i < TimeFrame; i++)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds((int)Math.Round(duration)));
                        int index = new Random().Next(0, FailureXes.Count);
                        int boolean = new Random().Next(0, 2);
                        if (boolean == 1 )
                        {
                            int numberOfErrors = new Random().Next();
                            for (int j = 0; j == MAXERRORCOUNT; j++)
                            {
                                var idF = FailureXes[index];
                                var idComp = failObj.IdComponentFailureX[new Random().Next(0, failObj.IdComponentFailureX.Length)];
                                ErrorOccured?.Invoke(Plane, idF, PlaneType, idComp);
                            }
                        }
                        var idFailure = FailureXes[index];
                        var idComponentFailure = failObj.IdComponentFailureX[new Random().Next(0, failObj.IdComponentFailureX.Length)];
                        ErrorOccured?.Invoke(Plane, idFailure, PlaneType, idComponentFailure);
                    }
                    SimulationFinished?.Invoke();
                });

                _thread.Start();
        }
    }
}