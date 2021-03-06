﻿using System;
using System.Threading.Tasks;

namespace Altium.Test.Scenarios.Api
{
  public interface ISortScenarioProvider
  {
    void NotifyError(Exception ex);
    void Init();
    Task<SortScenarioSettings> GetSettings();
    Task<bool> Confirm(SortScenarioSettings settings);
    void Cancel();
    void NotifyStarted();
    void NotifyFinished(TimeSpan time);
  }
}
