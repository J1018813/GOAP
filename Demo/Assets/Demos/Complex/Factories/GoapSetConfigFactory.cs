﻿using CrashKonijn.Goap.Behaviours;
using CrashKonijn.Goap.Classes.Builders;
using CrashKonijn.Goap.Configs;
using Demos.Complex.Classes.Items;
using Demos.Complex.Factories.Extensions;
using Demos.Complex.Interfaces;

namespace Demos.Complex.Factories
{
    public class GoapSetConfigFactory : GoapSetFactoryBase
    {
        public override IGoapSetConfig Create()
        {
            var builder = new GoapSetBuilder("ComplexSet");

            // Goals
            builder.AddWanderGoal();
            
            builder.AddCreateItemGoal<Axe>();
            builder.AddCreateItemGoal<Pickaxe>();
            builder.AddCleanItemsGoal();
            builder.AddFixHungerGoal();

            builder.AddGatherItemGoal<Iron>();
            builder.AddGatherItemGoal<Wood>();
            
            // Actions
            builder.AddWanderAction();

            builder.AddPickupItemAction<Wood>();
            builder.AddPickupItemAction<Iron>();
            builder.AddPickupItemAction<Pickaxe>();
            builder.AddPickupItemAction<Axe>();
            builder.AddPickupItemAction<IEatable>();
            
            builder.AddGatherItemAction<Wood, Axe>();
            builder.AddGatherItemAction<Iron, Pickaxe>();

            builder.AddCreateItemAction<Pickaxe>();
            builder.AddCreateItemAction<Axe>();

            builder.AddHaulItemAction();

            builder.AddEatAction();
            
            // TargetSensors
            builder.AddWanderTargetSensor();
            builder.AddTransformTargetSensor();
            
            builder.AddClosestItemTargetSensor<Axe>();
            builder.AddClosestItemTargetSensor<Iron>();
            builder.AddClosestItemTargetSensor<Pickaxe>();
            builder.AddClosestItemTargetSensor<Wood>();
            builder.AddClosestItemTargetSensor<IEatable>();
            
            builder.AddClosestSourceTargetSensor<Iron>();
            builder.AddClosestSourceTargetSensor<Wood>();

            // WorldSensors
            builder.AddIsHoldingSensor<Axe>();
            builder.AddIsHoldingSensor<Pickaxe>();
            builder.AddIsHoldingSensor<Wood>();
            builder.AddIsHoldingSensor<Iron>();
            builder.AddIsHoldingSensor<IEatable>();
            
            builder.AddIsInWorldSensor<Axe>();
            builder.AddIsInWorldSensor<Pickaxe>();
            builder.AddIsInWorldSensor<Wood>();
            builder.AddIsInWorldSensor<Iron>();
            builder.AddIsInWorldSensor<IEatable>();
            
            builder.AddItemOnFloorSensor();

            return builder.Build();
        }
    }
}