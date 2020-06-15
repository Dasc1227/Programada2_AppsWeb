
package ecci_holamundo;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "ECCI_HolaMundo", targetNamespace = "urn:ECCI_HolaMundo", wsdlLocation = "http://titanic.ecci.ucr.ac.cr/~bsolano/HolaMundoServiceDocumentLiteral/?wsdl")
public class ECCIHolaMundo
    extends Service
{

    private final static URL ECCIHOLAMUNDO_WSDL_LOCATION;
    private final static WebServiceException ECCIHOLAMUNDO_EXCEPTION;
    private final static QName ECCIHOLAMUNDO_QNAME = new QName("urn:ECCI_HolaMundo", "ECCI_HolaMundo");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://titanic.ecci.ucr.ac.cr/~bsolano/HolaMundoServiceDocumentLiteral/?wsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        ECCIHOLAMUNDO_WSDL_LOCATION = url;
        ECCIHOLAMUNDO_EXCEPTION = e;
    }

    public ECCIHolaMundo() {
        super(__getWsdlLocation(), ECCIHOLAMUNDO_QNAME);
    }

    public ECCIHolaMundo(WebServiceFeature... features) {
        super(__getWsdlLocation(), ECCIHOLAMUNDO_QNAME, features);
    }

    public ECCIHolaMundo(URL wsdlLocation) {
        super(wsdlLocation, ECCIHOLAMUNDO_QNAME);
    }

    public ECCIHolaMundo(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, ECCIHOLAMUNDO_QNAME, features);
    }

    public ECCIHolaMundo(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public ECCIHolaMundo(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns ECCIHolaMundoPort
     */
    @WebEndpoint(name = "ECCI_HolaMundoPort")
    public ECCIHolaMundoPort getECCIHolaMundoPort() {
        return super.getPort(new QName("urn:ECCI_HolaMundo", "ECCI_HolaMundoPort"), ECCIHolaMundoPort.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns ECCIHolaMundoPort
     */
    @WebEndpoint(name = "ECCI_HolaMundoPort")
    public ECCIHolaMundoPort getECCIHolaMundoPort(WebServiceFeature... features) {
        return super.getPort(new QName("urn:ECCI_HolaMundo", "ECCI_HolaMundoPort"), ECCIHolaMundoPort.class, features);
    }

    private static URL __getWsdlLocation() {
        if (ECCIHOLAMUNDO_EXCEPTION!= null) {
            throw ECCIHOLAMUNDO_EXCEPTION;
        }
        return ECCIHOLAMUNDO_WSDL_LOCATION;
    }

}
