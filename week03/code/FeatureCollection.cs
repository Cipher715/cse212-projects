public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Feature[] features {get; set;}

}

public class Feature {
    public Property properties {get; set;}
}

public class Property {
    public string place {get; set;}
    public float mag {get; set;}

}