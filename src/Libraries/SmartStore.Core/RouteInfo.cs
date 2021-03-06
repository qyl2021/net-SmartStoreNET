using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;

namespace SmartStore
{
	public class RouteInfo
	{
		public RouteInfo(RouteInfo cloneFrom)
			: this(cloneFrom.Action, cloneFrom.Controller, new RouteValueDictionary(cloneFrom.RouteValues))
		{
			Guard.ArgumentNotNull(() => cloneFrom);
		}

        public RouteInfo(string action, object routeValues)
            : this(action, null, routeValues)
        {
        }

        public RouteInfo(string action, string controller, object routeValues) 
			: this(action, controller, new RouteValueDictionary(routeValues))
		{
		}

        public RouteInfo(string action, IDictionary<string, object> routeValues)
            : this(action, null, routeValues)
        {
        }

        public RouteInfo(string action, string controller, IDictionary<string, object> routeValues)
			: this(action, controller, new RouteValueDictionary(routeValues))
		{
			Guard.ArgumentNotNull(() => routeValues);
		}

        public RouteInfo(string action, RouteValueDictionary routeValues)
            : this(action, null, routeValues)
        {
        }

        public RouteInfo(string action, string controller, RouteValueDictionary routeValues)
		{
			Guard.ArgumentNotEmpty(() => action);
			Guard.ArgumentNotNull(() => routeValues);

			this.Action = action;
			this.Controller = controller;
			this.RouteValues = routeValues;
		}

		public string Action
		{
			get;
			private set;
		}

		public string Controller
		{
			get;
			private set;
		}

		public RouteValueDictionary RouteValues
		{
			get;
			private set;
		}

	}
}
