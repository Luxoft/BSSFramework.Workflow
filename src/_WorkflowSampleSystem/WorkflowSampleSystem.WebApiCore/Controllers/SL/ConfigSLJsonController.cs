﻿using System;

using Framework.Configuration.BLL;
using Framework.DomainDriven.BLL;
using Framework.Notification.DTO;

using Microsoft.AspNetCore.Mvc;

namespace WorkflowSampleSystem.WebApiCore.Controllers
{
    public class ConfigSLJsonController : Framework.Configuration.WebApi.ConfigSLJsonController
    {
        public ConfigSLJsonController()
            : base()
        {
        }

        [HttpPost(nameof(SaveSendedNotification))]
        public void SaveSendedNotification(NotificationEventDTO notification)
        {
            if (notification == null)
            {
                throw new ArgumentNullException(nameof(notification));
            }

            this.EvaluateC(DBSessionMode.Write, context =>
            {
                var bll = new SentMessageBLL(context);

                bll.Save(notification.ToSentMessage());
            });
        }
    }
}
