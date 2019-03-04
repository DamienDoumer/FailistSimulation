﻿using System;
using System.Collections.Generic;
using System.Threading;
using FailistSimulation.Models;

namespace FailistSimulation.Services
{
    public class Simulator
    {
        public List<IdFailureX> FailureXes { get; set; }
        public IdPlane Plane { get; set; }
        public double SecondsDuration { get; set; }
        public int TimeFrame { get; set; }
        public TypePlane PlaneType { get; set; }
        public event Action<IdPlane, IdFailureX, TypePlane, IdComponentFailureX> ErrorOccured;
        public event Action SimulationFinished;

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

        public void Simulate()
        {
            Thread thread;
            var failObj = DataAccessor.DeserializeData();
            var duration = Decimal.Divide(new Decimal(SecondsDuration), new Decimal(TimeFrame));
            for (int i = 0; i < TimeFrame; i++)
            {
                thread = new Thread(() =>
                {
                    Thread.Sleep(TimeSpan.FromSeconds((int)Math.Round(duration)));
                    int index = new Random().Next(0, FailureXes.Count);
                    var idFailure = FailureXes[index];
                    var idComponentFailure = failObj.IdComponentFailureX[new Random().Next(0, failObj.IdComponentFailureX.Length)];
                    ErrorOccured?.Invoke(Plane, idFailure, PlaneType, idComponentFailure);
                });
                thread.Start();
            }

            SimulationFinished?.Invoke();
        }
    }
}