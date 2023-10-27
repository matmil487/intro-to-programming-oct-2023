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

        await host.Scenario(api =>
        {
            api.Get.Url("/todo-list/" + Guid.NewGuid().ToString());
            api.StatusCodeShouldBe(404);

        });
    }
}