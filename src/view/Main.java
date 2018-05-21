package view;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.Pane;
import javafx.scene.layout.StackPane;
import javafx.stage.Stage;


public class Main extends Application implements EventHandler<ActionEvent> {

	Button button;

    @Override
    public void start(Stage primaryStage) throws Exception{
        Parent root = FXMLLoader.load(getClass().getResource("financeTracker.fxml"));
        primaryStage.setTitle("Finance Tracker");

        button = new Button();
        button.setText("Create User");
        button.setLayoutX(25);
        button.setLayoutY(25);
        button.setOnAction(this);

		Pane layout = new Pane();
		layout.getChildren().add(button);

		primaryStage.setScene(new Scene(layout, 800, 600));


		//Starting application
		primaryStage.show();
		Controller controller = new Controller();
    }

    public static void main(String[] args) {
        launch(args);

    }

	@Override
	public void handle(ActionEvent event) {
		if (event.getSource() == button) {
			System.out.println("hello");
		}
	}
}
