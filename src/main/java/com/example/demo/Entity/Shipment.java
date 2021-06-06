package com.example.demo.Entity;

import javax.persistence.*;
import java.util.Date;

@Entity
@Table(name = "at")
public class Shipment {
      @Id
      @Column(name="ID")
      long ID;
     @Column(name="Received")
     Date Received;
     @ManyToOne
//    @ManyToOne(fetch = FetchType.LAZY, optional = false)
//    @MapsId("branchId")
    @JoinColumn(name="Branch_ID")
//    @JoinTable(name = "branch",
//            joinColumns = {@JoinColumn(name = "ID",referencedColumnName = "Branch_ID",
//                    nullable = false)})
    Branch shipmentBranch;

//    private static final long serialVersionUID = 1L;
//    @Id
    @ManyToOne(fetch = FetchType.LAZY, optional = false)
//    @MapsId("cargoId")
    @JoinColumn(name="Cargo_ID")
//    @JoinTable(name = "cargo",
//    joinColumns = {@JoinColumn(name = "ID",referencedColumnName = "Cargo_ID",
//    nullable = false)})
    Cargo shipmentCargo;
//    @Id

//    @Id


    public void setID(long ID) {
        this.ID = ID;
    }

    public void setShipmentCargo(Cargo shipmentCargo) {
        this.shipmentCargo = shipmentCargo;
    }

    public void setShipmentBranch(Branch shipmentBranch) {
        this.shipmentBranch = shipmentBranch;
    }

    public void setReceived(Date received) {
        Received = received;
    }

    public long getID() {
        return ID;
    }

    public Cargo getShipmentCargo() {
        return shipmentCargo;
    }

    public Branch getShipmentBranch() {
        return shipmentBranch;
    }

    public Date getReceived() {
        return Received;
    }
}
