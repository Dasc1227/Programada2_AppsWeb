
package ecci_holamundo;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para anonymous complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="saludeResult" type="{http://www.w3.org/2001/XMLSchema}string"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "saludeResult"
})
@XmlRootElement(name = "saludeReturn")
public class SaludeReturn {

    @XmlElement(required = true)
    protected String saludeResult;

    /**
     * Obtiene el valor de la propiedad saludeResult.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSaludeResult() {
        return saludeResult;
    }

    /**
     * Define el valor de la propiedad saludeResult.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSaludeResult(String value) {
        this.saludeResult = value;
    }

}
