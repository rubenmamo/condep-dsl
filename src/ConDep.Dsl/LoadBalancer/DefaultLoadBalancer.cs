﻿using ConDep.Dsl.Config;

namespace ConDep.Dsl.LoadBalancer
{
    public class DefaultLoadBalancer : ILoadBalance
    {
        public void BringOffline(string serverName, string farm, LoadBalancerSuspendMethod suspendMethod, IReportStatus status)
        {
        }

        public void BringOnline(string serverName, string farm, IReportStatus status)
        {
        }

        public LbMode Mode { get; set; }
    }
}