using Reactive.Bindings;
using System;

namespace XFEventToCommandBehavior.Sample.ViewModels
{
	public class MainPageViewModel
	{
		public ReactiveProperty<String> Message { get; }
		public ReactiveProperty<String> Url { get; }

		public ReactiveCommand Loaded { get; }

		public ReactiveCommand<string> Navigating { get; }
		public ReactiveCommand<string> Navigated { get; }

		public MainPageViewModel()
		{
			Message = new ReactiveProperty<string>();
			Url = new ReactiveProperty<string>();

			Loaded = new ReactiveCommand();
			Loaded.Subscribe(_ =>
			{
				Message.Value = "Loaded\n";
				Url.Value = "https://github.com/";
			});

			Navigating = new ReactiveCommand<string>();
			Navigating.Subscribe(p => Message.Value += "Navigating : " + p + "\n");

			Navigated = new ReactiveCommand<string>();
			Navigated.Subscribe(p => Message.Value += "Navigated : " + p + "\n");
		}
	}
}

