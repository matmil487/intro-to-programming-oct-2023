
using Alba;

namespace DemoApi.ContractTests.Todos;
public class GettingTodos
{

	[Fact]
	public async Task CanGetATodo()
	{
		var host = await AlbaHost.For<Program>();

		await host.Scenario(api =>
		{
			api.Get.Url("/todo-list/e9df7a6a-bdb7-422c-9dcc-b5bdb0bcd4b0");
			api.StatusCodeShouldBeOk();
		});



	}
	[Fact]
	public async Task IfNoTodoFourOhFourIsReturned()
	{
		var host = await AlbaHost.For<Program>();
		await host.Scenario(api =>
		{
			api.Get.Url("/todo-list/a30390fe-39a2-49a3-aa63-2708415ac675");
			api.StatusCodeShouldBe(404);

		});
	}
}
