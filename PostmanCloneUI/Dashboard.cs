using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API ...";
        resultText.Text = "";

        //Validate the API URL
        if (api.IsValidApiUrl(apiText.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        try
        {

            resultText.Text = await api.CallApiAsync(apiText.Text);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultText.Text = "Error:" + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {

    }
}
