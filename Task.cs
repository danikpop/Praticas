//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public enum TaskState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Open = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Completed = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Canceled = 2,
	}
	
	/// <summary>
	/// Generic activity representing work needed to be done.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("task")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class Task : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ActivityAdditionalParams = "activityadditionalparams";
			public const string ActivityId = "activityid";
			public const string Id = "activityid";
			public const string ActivityTypeCode = "activitytypecode";
			public const string ActualDurationMinutes = "actualdurationminutes";
			public const string ActualEnd = "actualend";
			public const string ActualStart = "actualstart";
			public const string Category = "category";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CrmTaskAssignedUniqueId = "crmtaskassigneduniqueid";
			public const string Description = "description";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsBilled = "isbilled";
			public const string IsRegularActivity = "isregularactivity";
			public const string IsWorkflowCreated = "isworkflowcreated";
			public const string LastOnHoldTime = "lastonholdtime";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OnHoldTime = "onholdtime";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string PercentComplete = "percentcomplete";
			public const string PriorityCode = "prioritycode";
			public const string ProcessId = "processid";
			public const string RegardingObjectId = "regardingobjectid";
			public const string ScheduledDurationMinutes = "scheduleddurationminutes";
			public const string ScheduledEnd = "scheduledend";
			public const string ScheduledStart = "scheduledstart";
			public const string ServiceId = "serviceid";
			public const string SLAId = "slaid";
			public const string SLAInvokedId = "slainvokedid";
			public const string SortDate = "sortdate";
			public const string StageId = "stageid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string Subcategory = "subcategory";
			public const string Subject = "subject";
			public const string SubscriptionId = "subscriptionid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TraversedPath = "traversedpath";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string Lead_Tasks = "Lead_Tasks";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Task() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "task";
		
		public const string PrimaryIdAttribute = "activityid";
		
		public const string PrimaryNameAttribute = "subject";
		
		public const int EntityTypeCode = 4212;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityadditionalparams")]
		public string ActivityAdditionalParams
		{
			get
			{
				return this.GetAttributeValue<string>("activityadditionalparams");
			}
			set
			{
				this.OnPropertyChanging("ActivityAdditionalParams");
				this.SetAttributeValue("activityadditionalparams", value);
				this.OnPropertyChanged("ActivityAdditionalParams");
			}
		}
		
		/// <summary>
		/// Unique identifier of the task.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		public System.Nullable<System.Guid> ActivityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activityid");
			}
			set
			{
				this.OnPropertyChanging("ActivityId");
				this.SetAttributeValue("activityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ActivityId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ActivityId = value;
			}
		}
		
		/// <summary>
		/// Type of activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypecode")]
		public string ActivityTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("activitytypecode");
			}
		}
		
		/// <summary>
		/// Type the number of minutes spent on the task. The duration is used in reporting.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualdurationminutes")]
		public System.Nullable<int> ActualDurationMinutes
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("actualdurationminutes");
			}
			set
			{
				this.OnPropertyChanging("ActualDurationMinutes");
				this.SetAttributeValue("actualdurationminutes", value);
				this.OnPropertyChanged("ActualDurationMinutes");
			}
		}
		
		/// <summary>
		/// Enter the actual end date and time of the task. By default, it displays when the activity was completed or canceled.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualend")]
		public System.Nullable<System.DateTime> ActualEnd
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualend");
			}
			set
			{
				this.OnPropertyChanging("ActualEnd");
				this.SetAttributeValue("actualend", value);
				this.OnPropertyChanged("ActualEnd");
			}
		}
		
		/// <summary>
		/// Enter the actual start date and time for the task. By default, it displays when the task was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstart")]
		public System.Nullable<System.DateTime> ActualStart
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualstart");
			}
			set
			{
				this.OnPropertyChanging("ActualStart");
				this.SetAttributeValue("actualstart", value);
				this.OnPropertyChanged("ActualStart");
			}
		}
		
		/// <summary>
		/// Type a category to identify the task type, such as lead gathering or customer follow up, to tie the task to a business group or function.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
		public string Category
		{
			get
			{
				return this.GetAttributeValue<string>("category");
			}
			set
			{
				this.OnPropertyChanging("Category");
				this.SetAttributeValue("category", value);
				this.OnPropertyChanged("Category");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Assigned Task Unique Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crmtaskassigneduniqueid")]
		public System.Nullable<System.Guid> CrmTaskAssignedUniqueId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("crmtaskassigneduniqueid");
			}
			set
			{
				this.OnPropertyChanging("CrmTaskAssignedUniqueId");
				this.SetAttributeValue("crmtaskassigneduniqueid", value);
				this.OnPropertyChanged("CrmTaskAssignedUniqueId");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the task.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Information which specifies whether the task was billed as part of resolving a case.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbilled")]
		public System.Nullable<bool> IsBilled
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isbilled");
			}
			set
			{
				this.OnPropertyChanging("IsBilled");
				this.SetAttributeValue("isbilled", value);
				this.OnPropertyChanged("IsBilled");
			}
		}
		
		/// <summary>
		/// Information regarding whether the activity is a regular activity type or event type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregularactivity")]
		public System.Nullable<bool> IsRegularActivity
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isregularactivity");
			}
		}
		
		/// <summary>
		/// Information which specifies if the task was created from a workflow rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowcreated")]
		public System.Nullable<bool> IsWorkflowCreated
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isworkflowcreated");
			}
			set
			{
				this.OnPropertyChanging("IsWorkflowCreated");
				this.SetAttributeValue("isworkflowcreated", value);
				this.OnPropertyChanged("IsWorkflowCreated");
			}
		}
		
		/// <summary>
		/// Contains the date and time stamp of the last on hold time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Shows how long, in minutes, that the record was on hold.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Shows the record owner's business unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team that owns the task.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user that owns the task.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Type the percentage complete value for the task to track tasks to completion.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("percentcomplete")]
		public System.Nullable<int> PercentComplete
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("percentcomplete");
			}
			set
			{
				this.OnPropertyChanging("PercentComplete");
				this.SetAttributeValue("percentcomplete", value);
				this.OnPropertyChanged("PercentComplete");
			}
		}
		
		/// <summary>
		/// Select the priority so that preferred customers or critical issues are handled quickly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode");
			}
			set
			{
				this.OnPropertyChanging("PriorityCode");
				this.SetAttributeValue("prioritycode", value);
				this.OnPropertyChanged("PriorityCode");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Choose the record that the task relates to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// Scheduled duration of the task, specified in minutes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
		public System.Nullable<int> ScheduledDurationMinutes
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes");
			}
		}
		
		/// <summary>
		/// Enter the expected due date and time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
		public System.Nullable<System.DateTime> ScheduledEnd
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
			}
			set
			{
				this.OnPropertyChanging("ScheduledEnd");
				this.SetAttributeValue("scheduledend", value);
				this.OnPropertyChanged("ScheduledEnd");
			}
		}
		
		/// <summary>
		/// Enter the expected due date and time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
		public System.Nullable<System.DateTime> ScheduledStart
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
			}
			set
			{
				this.OnPropertyChanging("ScheduledStart");
				this.SetAttributeValue("scheduledstart", value);
				this.OnPropertyChanged("ScheduledStart");
			}
		}
		
		/// <summary>
		/// Choose the service that is associated with this activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
		public Microsoft.Xrm.Sdk.EntityReference ServiceId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("serviceid");
			}
			set
			{
				this.OnPropertyChanging("ServiceId");
				this.SetAttributeValue("serviceid", value);
				this.OnPropertyChanged("ServiceId");
			}
		}
		
		/// <summary>
		/// Choose the service level agreement (SLA) that you want to apply to the Task record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
		
		/// <summary>
		/// Last SLA that was applied to this Task. This field is for internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
		
		/// <summary>
		/// Shows the date and time by which the activities are sorted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sortdate")]
		public System.Nullable<System.DateTime> SortDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("sortdate");
			}
			set
			{
				this.OnPropertyChanging("SortDate");
				this.SetAttributeValue("sortdate", value);
				this.OnPropertyChanged("SortDate");
			}
		}
		
		/// <summary>
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Shows whether the task is open, completed, or canceled. Completed and canceled tasks are read-only and can't be edited.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Entities.TaskState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Entities.TaskState)(System.Enum.ToObject(typeof(Entities.TaskState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Select the task's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Type a subcategory to identify the task type and relate the activity to a specific product, sales region, business group, or other function.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subcategory")]
		public string Subcategory
		{
			get
			{
				return this.GetAttributeValue<string>("subcategory");
			}
			set
			{
				this.OnPropertyChanging("Subcategory");
				this.SetAttributeValue("subcategory", value);
				this.OnPropertyChanged("Subcategory");
			}
		}
		
		/// <summary>
		/// Type a short description about the objective or primary topic of the task.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
		public string Subject
		{
			get
			{
				return this.GetAttributeValue<string>("subject");
			}
			set
			{
				this.OnPropertyChanging("Subject");
				this.SetAttributeValue("subject", value);
				this.OnPropertyChanged("Subject");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
		public System.Nullable<System.Guid> SubscriptionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid");
			}
			set
			{
				this.OnPropertyChanging("SubscriptionId");
				this.SetAttributeValue("subscriptionid", value);
				this.OnPropertyChanged("SubscriptionId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version number of the task.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 Lead_Tasks
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Tasks")]
		public Entities.Lead Lead_Tasks
		{
			get
			{
				return this.GetRelatedEntity<Entities.Lead>("Lead_Tasks", null);
			}
			set
			{
				this.OnPropertyChanging("Lead_Tasks");
				this.SetRelatedEntity<Entities.Lead>("Lead_Tasks", null, value);
				this.OnPropertyChanged("Lead_Tasks");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public Task(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["activityid"] = base.Id;
                        break;
                    case "activityid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}