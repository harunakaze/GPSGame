using UnityEngine;

public interface IPredatorState {
    void SEnter();
    void SExit();

    void SUpdate();
    void SFixedUpdate();

    void SOnCollisionEnter(Collision other);
    void SOnTriggerEnter(Collider other);

    void SOnCollisionEnter2D(Collision2D other);
}
