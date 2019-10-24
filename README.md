# moq.SetupAsync

Extension for Moq that allow to easily mock async methods

[![Version](https://img.shields.io/nuget/v/Talentsoft.Moq.SetupAsync.svg)](https://www.nuget.org/packages/Talentsoft.Moq.SetupAsync)
[![Downloads](https://img.shields.io/nuget/dt/Talentsoft.Moq.SetupAsync.svg)](https://www.nuget.org/packages/Talentsoft.Moq.SetupAsync)

```csharp
  var mock = new Mock<IFoo>();

  // Setup of async function is as simple as doing it for standard function
  mock.SetupAsync(x => x.ExecFuncAsync(It.IsAny<string>())).Returns<string>(s => "hello " + s);
  // In particular compared to the syntax provided by Moq
  mock.Setup(x => x.ExecFuncAsync(It.IsAny<string>())).ReturnsAsync<string, IFoo, object>(s => "hello " + s);

  // And we also provide support of async actions (task without return value), which are missing in Moq
  mock.SetupAsync(x => x.DoActionAsync());
  // With the possibility to add callback on them
  mock.SetupAsync(x => x.DoActionAsync(It.IsAny<string>())).Callback<string>(s => { });
  // But if you stick to the Setup syntax instead of the SetupAsync you can also use our new CallbackAsync extension
  mock.Setup(x => x.DoActionAsync(It.IsAny<string>())).CallbackAsync<string, IFoo>(s => {});
```

This work has been inspired in the first place by a discussion on stackoverflow:
https://stackoverflow.com/questions/21253523/setup-async-task-callback-in-moq-framework

Then our decision has been validated when we read that there is an opened issue that seems frozen unfortunately:
https://github.com/moq/moq4/issues/384
