using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector2 moveDirection = new Vector2(horizontal, vertical);
        transform.Translate(moveDirection * _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if(_numSeedsLeft > 0)
        {
            Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);

            _numSeedsLeft -= 1;
            _numSeedsPlanted += 1;

            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            
        }
    }
}
